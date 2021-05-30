import React from "react";
import "./App.css";
import MainLayout from "./pages/MainLayout";
import { Route, Switch } from "react-router-dom";
import { Catalog } from "./pages/Catalog";
import Response from "./pages/Response";
import RoomPage from "./pages/Room";

function App() {
  return (
    <MainLayout>
      <Switch>
        <Route path="/" exact component={Catalog} />
        <Route path="/response" exact component={Response} />
        <Route path="/room" exact component={RoomPage} />
      </Switch>
    </MainLayout>
  );
}

export default App;
