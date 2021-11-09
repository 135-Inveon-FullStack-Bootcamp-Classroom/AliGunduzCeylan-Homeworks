import Header from "../Header";

const Layout = ({ children }) => {
  return (
    <div className="App">
      <Header />
      <div style={{ margin: 50 }}>{children}</div>
    </div>
  );
};

export default Layout;
