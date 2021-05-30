import { useStore } from "effector-react";
import * as React from "react";
import dayjs from "dayjs";
import { useEffect } from "react";
import { Comment, Avatar, Tooltip } from "antd";
import { $comments, commentsFx } from "../../models/comments";

const Response = () => {
  const comments = useStore($comments);
  useEffect(() => {
    commentsFx();
  }, []);
  return (
    <>
      {comments.map((comment) => {
        return (
          <Comment
            key={comment.id}
            author={`${comment.firstName} ${comment.lastName}`}
            avatar={
              <Avatar
                src="https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png"
                alt="Han Solo"
              />
            }
            content={<p>{comment.comment}</p>}
            datetime={
              <Tooltip
                title={dayjs(comment.createDate).format("DD-MM-YYYY HH:mm:ss")}
              >
                <span>{dayjs(comment.createDate).format("DD/MM/YYYY")}</span>
              </Tooltip>
            }
          ></Comment>
        );
      })}
    </>
  );
};

export default Response;
