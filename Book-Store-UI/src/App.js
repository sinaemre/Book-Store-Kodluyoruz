
import './App.css';
import Login from './components/Login';
import {Routes,Route,Link} from "react-router-dom";
import Home from './pages/Home'
import About from './pages/About'
import Products from './components/Products';
import ProductDetails from './components/ProductDetails'

function App() {
  return (
    <div className='App' >

    
      

      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/about" element={<About />} />
        <Route path="/login" element={<Login />} />
        <Route path="/products" element={<Products />} />
        <Route path="/products/:id" element={<ProductDetails />} />
      </Routes>
      
    </div>
  );
}

export default App;
