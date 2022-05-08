import React from 'react';
import logo from './logo.svg';
import './css/App.css';
import UserScreen from './screens/UserScreen';

const colors = {
  purple: '#764AF1',
  green: '#36AE7C',
  blue: '#187498',
};

export const ColorContext = React.createContext(colors);

function App() {
  return (
    <div className="App">
      <ColorContext.Provider value={colors}>
        <UserScreen />
      </ColorContext.Provider>
    </div>
  );
}

export default App;
