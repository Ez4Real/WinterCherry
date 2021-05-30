import * as React from "react";
import { Drawer, DatePicker, Input, Button, Modal, Radio } from "antd";
import { CreditCardOutlined, WalletOutlined } from "@ant-design/icons";
import { $drawerShow, updateDrawerShow } from "../../models/roomId";
import { useStore } from "effector-react";
import { useState } from "react";

const { RangePicker } = DatePicker;
const { TextArea } = Input;

export const CheckInDrawer = (props: any) => {
  const [showModal, setShowModal] = useState(false);
  const [radioValue, setRadioValue] = useState(1);
  const drawerShow = useStore($drawerShow);
  console.log(drawerShow);
  const closeDrawerHandler = () => {
    updateDrawerShow(false);
  };
  const onRadioValueChanged = (e: any) => {
    setRadioValue(e.target.value);
  };
  return (
    <>
      <Drawer
        title="Бронювання"
        placement="right"
        onClose={closeDrawerHandler}
        visible={drawerShow}
        destroyOnClose
        width="500"
        footer={
          <Button
            type="primary"
            htmlType="submit"
            onClick={() => {
              updateDrawerShow(false);
              setShowModal(true);
            }}
          >
            Оплатити
          </Button>
        }
      >
        <div>Виберіть дату</div>
        <br />
        <RangePicker showTime size="large" />
        <br />
        <br />
        <p>Побажання</p>
        <TextArea rows={5} />
      </Drawer>
      <Modal
        title="Виберіть тип оплати"
        centered
        visible={showModal}
        onOk={() => setShowModal(false)}
        onCancel={() => setShowModal(false)}
      >
        <Radio.Group value={radioValue} onChange={onRadioValueChanged}>
          <Radio value={1}>
            <WalletOutlined /> Готівкою
          </Radio>
          <Radio value={2}>
            <CreditCardOutlined /> Картою
          </Radio>
        </Radio.Group>
      </Modal>
    </>
  );
};
