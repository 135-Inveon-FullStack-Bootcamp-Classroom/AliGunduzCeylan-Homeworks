import "./App.css";
import { WeatherProvider } from "./context/WeatherContext";
import { FormProvider } from "./context/FormContext";

import Container from "./components/Container.js";

function App() {
  return (
    <div className="App">
      <FormProvider>
        <WeatherProvider>
          <Container></Container>
        </WeatherProvider>
      </FormProvider>
    </div>
  );
}

export default App;
