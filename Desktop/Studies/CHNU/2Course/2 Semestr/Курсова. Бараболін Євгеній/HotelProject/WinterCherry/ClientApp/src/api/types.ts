export interface ICatalog {
  id: number;
  roomNum: number;
  peopleNum: number;
  roomType: string;
  roomIMG: string;
  price: string;
  description: string;
  rate: number;
}
export interface IRoomImages {
  id: number;
  roomId: number;
  imgPath: string;
}
export interface IComment {
  id: number;
  firstName: string;
  lastName: string;
  comment: string;
  clientID: number;
  createDate: string;
}
