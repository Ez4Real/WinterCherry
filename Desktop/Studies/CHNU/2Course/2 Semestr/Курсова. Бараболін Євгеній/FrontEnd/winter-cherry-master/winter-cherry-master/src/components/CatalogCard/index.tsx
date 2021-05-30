import React from "react";
import { Card, Col, Row } from "antd";
import "./CatalogCard.css";
import { updateSelectedRoom } from "../../models/roomId";
import { NavLink } from "react-router-dom";

const { Meta } = Card;
export function CatalogCard(props: any) {
  const { catalog, tabName } = props;
  return (
    <div className="site-card-wrapper">
      <Row gutter={{ xs: 24, sm: 12, md: 8, lg: 6 }}>
        {catalog
          .filter((room: any) => room.roomType === tabName)
          .map((room: any) => {
            return (
              <>
                <Col span={6} key={room.roomType}>
                  <NavLink to="/room" exact>
                    <Card
                      key={room.roomType}
                      hoverable
                      className="feed-card"
                      size="small"
                      onClick={() => updateSelectedRoom(room.id)}
                      cover={<img alt={room.roomType} src={room.roomIMG} />}
                    >
                      <Meta
                        key={room.roomType}
                        title={room.roomType}
                        description={room.description}
                      />
                    </Card>
                  </NavLink>
                </Col>
              </>
            );
          })}
      </Row>
    </div>
  );
}
