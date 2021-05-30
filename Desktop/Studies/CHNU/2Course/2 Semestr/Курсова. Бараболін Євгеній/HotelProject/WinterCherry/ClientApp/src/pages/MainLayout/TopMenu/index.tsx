import * as React from "react";
import { Menu } from "antd";
import "../Layout.css";
import { NavLink, withRouter } from "react-router-dom";

function TopMenu(props: any) {
  const { location } = props;
  return (
    <>
      <Menu
        theme="dark"
        mode="horizontal"
        defaultSelectedKeys={["/"]}
        selectedKeys={[location.pathname]}
      >
        <Menu.Item key="/">
          <NavLink to="/" exact>
            Каталог
          </NavLink>
        </Menu.Item>
        <Menu.Item key="/response">
          <NavLink to="/response" exact>
            Відгуки
          </NavLink>
        </Menu.Item>
      </Menu>
    </>
  );
}

export default withRouter(TopMenu);
