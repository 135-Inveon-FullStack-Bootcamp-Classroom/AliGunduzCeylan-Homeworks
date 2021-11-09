import CapsList from "./Components/CapsList";
import SingleCaps from "./Components/SingleCaps";

import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

import MemesProvider from "./Contexts/MemesContext";

function App() {
  return (
    <MemesProvider>
      <Router>
        <Routes>
          <Route path="/" element={<CapsList />} />
          <Route path="/single-caps/:id" element={<SingleCaps />} />
        </Routes>
      </Router>
    </MemesProvider>
  );
}

export default App;
