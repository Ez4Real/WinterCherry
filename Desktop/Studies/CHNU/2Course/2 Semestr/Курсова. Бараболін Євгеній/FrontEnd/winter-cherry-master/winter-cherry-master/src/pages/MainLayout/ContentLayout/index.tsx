import * as React from "react";
import { Layout } from "antd";
import "../Layout.css";

const { Content } = Layout;

export const ContentLayout = (props: any) => {
  return (
    <>
      <Content className="content-layout">
        <div className="site-layout-main">
          <main>{props.children}</main>
        </div>
      </Content>
    </>
  );
};
