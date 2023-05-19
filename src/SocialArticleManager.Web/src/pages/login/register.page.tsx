import React from "react";
import { Link } from "react-router-dom";

export const RegisterPage = () => {
  return (
    <>
      <div className="container">
        <div className="row">
          <div className="col-md-6 offset-md-3">
            <div className="card my-5">
              <div className="card-img-left d-none d-md-flex">
                {/* Background image for card set in CSS! */}
              </div>
              <div className="card-body p-4 p-sm-5">
                <h5 className="card-title text-center mb-5 fw-light fs-5">
                  Register
                </h5>
                <form>
                  <div className="form-floating mb-3">
                    <input
                      type="text"
                      className="form-control"
                      id="floatingInputUsername"
                      placeholder="myusername"
                    />
                    <label htmlFor="floatingInputUsername">Username</label>
                  </div>
                  <div className="form-floating mb-3">
                    <input
                      type="email"
                      className="form-control"
                      id="floatingInputEmail"
                      placeholder="name@example.com"
                    />
                    <label htmlFor="floatingInputEmail">Email address</label>
                  </div>
                  <hr />
                  <div className="form-floating mb-3">
                    <input
                      type="password"
                      className="form-control"
                      id="floatingPassword"
                      placeholder="Password"
                    />
                    <label htmlFor="floatingPassword">Password</label>
                  </div>
                  <div className="form-floating mb-3">
                    <input
                      type="password"
                      className="form-control"
                      id="floatingPasswordConfirm"
                      placeholder="Confirm Password"
                    />
                    <label htmlFor="floatingPasswordConfirm">
                      Confirm Password
                    </label>
                  </div>
                  <div className="d-grid mb-2">
                    <button
                      className="btn btn-lg btn-primary btn-login fw-bold text-uppercase"
                      type="submit"
                    >
                      Register
                    </button>
                  </div>

                  <Link
                    className="d-block text-center mt-2 small"
                    to={"/login"}
                  >
                    Have an account? Sign In
                  </Link>
                  <hr className="my-4" />
                  <div className="d-grid mb-2">
                    <button
                      className="btn btn-lg btn-google btn-login fw-bold text-uppercase"
                      type="submit"
                    >
                      <i className="fab fa-google me-2" /> Sign up with Google
                    </button>
                  </div>
                  <div className="d-grid">
                    <button
                      className="btn btn-lg btn-facebook btn-login fw-bold text-uppercase"
                      type="submit"
                    >
                      <i className="fab fa-facebook-f me-2" /> Sign up with
                      Facebook
                    </button>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};
