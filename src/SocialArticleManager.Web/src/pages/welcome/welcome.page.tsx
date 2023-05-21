import React from "react";
import { auth } from "../../config/firebase";

export const WelcomePage = () => {
  return (
    <>
      <div className="container">
        <div className="row">
          <div className="col-md-6 offset-md-3">
            <div className="card my-5">
              <form className="card-body cardbody-color p-lg-5">
                <div className="text-center">
                  <h1 className="display-4">Welcome</h1>
                  <h1 className="display-6">{auth.currentUser?.displayName}</h1>
                </div>
                <div className="text-center">
                  <img
                    src={
                      auth.currentUser?.photoURL ||
                      "https://cdn.pixabay.com/photo/2016/03/31/19/56/avatar-1295397__340.png"
                    }
                    className="img-fluid profile-image-pic img-thumbnail rounded-circle my-3"
                    width="200px"
                    alt="profile"
                  />
                </div>

                <hr className="hr" />
              </form>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};
