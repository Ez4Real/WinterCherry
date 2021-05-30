import * as React from "react";
import { useStore } from "effector-react";
import { $roomImages, roomImagesFx } from "../../models/roomImages";
import { useEffect } from "react";
import { Image, Descriptions, Rate, Button } from "antd";
import { $roomSelectedId, updateDrawerShow } from "../../models/roomId";
import "./Room.css";
import { CheckInDrawer } from "../../components/CheckInDrawer";

const RoomPage = (props: any) => {
  const roomImage = useStore($roomImages);
  const roomId = useStore($roomSelectedId);
  useEffect(() => {
    roomImagesFx();
  }, []);
  console.log(roomId);

  const checkInClinckHandle = () => {
    updateDrawerShow(true);
  };

  return (
    <div>
      <div className="booking-btn">
        <Button type="primary" shape="round" onClick={checkInClinckHandle}>
          Забронювати
        </Button>
      </div>
      <CheckInDrawer />
      <Descriptions title="Стандарт" bordered>
        <Descriptions.Item label="Номер кімнати">2</Descriptions.Item>
        <Descriptions.Item label="Кількість людей в кімнаті">
          3
        </Descriptions.Item>
        <Descriptions.Item label="Рейтинг">
          <Rate disabled defaultValue={4} />
        </Descriptions.Item>
        <Descriptions.Item label="Ціна" span={3}>
          300 грн
        </Descriptions.Item>
        <Descriptions.Item label="Опис">
          Простора кімната з виглядом на море
        </Descriptions.Item>
      </Descriptions>
      <Image.PreviewGroup>
        {roomImage.map((img) => {
          return (
            <>
              {img.roomId === roomId && (
                <Image
                  width={300}
                  src={img.imgPath}
                  style={{ padding: "20px" }}
                />
              )}
            </>
          );
        })}
      </Image.PreviewGroup>
    </div>
  );
};

export default RoomPage;
