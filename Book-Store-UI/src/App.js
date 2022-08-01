
import './App.css';
import Login from './components/Login';
import {Routes,Route,Link} from "react-router-dom";
import Home from './pages/Home'
import About from './pages/About'

function App() {
  return (
    <div className='App' >

    
      

      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="about" element={<About />} />
        <Route path="login" element={<Login />} />
      </Routes>
      
    </div>
  );
}

export default App;
