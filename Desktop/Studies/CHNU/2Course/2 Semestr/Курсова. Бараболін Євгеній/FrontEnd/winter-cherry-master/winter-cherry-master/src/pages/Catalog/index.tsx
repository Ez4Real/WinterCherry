import { useStore } from "effector-react";
import * as React from "react";
import { useEffect, useState } from "react";
import { Tabs } from "antd";
import { PageHeaderComponent } from "../../components/PageHeader";
import { CatalogCard } from "../../components/CatalogCard";
import { $catalog, catalogDataFx } from "../../models/catalog";

const { TabPane } = Tabs;

export const Catalog = () => {
  const [tabKey, setTabKey] = useState("Standart");
  const catalog = useStore($catalog);
  useEffect(() => {
    catalogDataFx();
  }, []);

  const TabHandler = (key: any) => {
    setTabKey(key);
  };

  return (
    <div>
      <PageHeaderComponent pageName="Кімнати" />
      <Tabs defaultActiveKey="1" onChange={TabHandler}>
        <TabPane tab="Стандарт" key="Standart">
          <CatalogCard catalog={catalog} tabName={tabKey} />
        </TabPane>
        <TabPane tab="Напівлюкс" key="Semi_Luxe">
          <CatalogCard catalog={catalog} tabName={tabKey} />
        </TabPane>

        <TabPane tab="Люкс" key="Luxe">
          <CatalogCard catalog={catalog} tabName={tabKey} />
        </TabPane>
      </Tabs>
    </div>
  );
};
