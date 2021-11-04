import logo from './logo.svg';
import './App.css';
import AppContainer from './components/app-container/AppContainer';
import TopHeader from './components/top-header/TopHeader';
import ScreenSection from './components/screen-section/ScreenSection';
import KeysSection from './components/key-section/KeySection';

function App() {
  return (
    <AppContainer>
      <TopHeader />
      <ScreenSection />
      <KeysSection />
    </AppContainer>
  );
}

export default App;
