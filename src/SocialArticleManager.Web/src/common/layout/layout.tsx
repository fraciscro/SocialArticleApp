import React from "react";
import { Outlet } from "react-router-dom";
import { Navbar } from "./navbar";

export const Layout = () => {
  return (
    <>
      <Navbar />
      <div className="container-fluid">
        <Outlet />
      </div>
    </>
  );
};
