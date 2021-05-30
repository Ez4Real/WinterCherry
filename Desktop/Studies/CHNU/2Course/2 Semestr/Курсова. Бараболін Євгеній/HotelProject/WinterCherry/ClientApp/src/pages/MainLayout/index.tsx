import React from "react";
import { Layout } from "antd";
import "./Layout.css";
import { Header } from "antd/lib/layout/layout";
import TopMenu from "./TopMenu";
import { ContentLayout } from "./ContentLayout";

const { Footer } = Layout;

function MainLayout(props: any) {
  return (
    <>
      <Layout className="layout">
        <Header>
          <TopMenu></TopMenu>
        </Header>
        <ContentLayout>{props.children}</ContentLayout>
        <Footer className="footer">
          Barabolin ©{new Date().getFullYear()} Created by Barabolin
        </Footer>
      </Layout>
    </>
  );
}

export default MainLayout;
