import * as React from "react";
import { PageHeader } from "antd";
import "./PageHeader.css";

interface IPageHeaderProps {
  pageName: string;
}

export const PageHeaderComponent = (props: IPageHeaderProps) => {
  const { pageName } = props;
  return (
    <div className="site-page-header-ghost-wrapper">
      <PageHeader ghost={false} title={pageName}></PageHeader>
    </div>
  );
};
