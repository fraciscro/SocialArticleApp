
import './App.css'
import { Route, Routes } from 'react-router-dom'
import { Layout } from './common/layout/layout'

function App() {

  return (
    <>
           <Routes>
              <Route
                path="/"
                element={
                    <Layout />
                }
              >
                {/* <Route
                  path="/company"
                  element={
                      <CompanyPage />
                  }
                />
                </Route> */}</Route>
            </Routes>
    </>
  )
}

export default App
