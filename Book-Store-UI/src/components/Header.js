import React from 'react'
import '../App.css' ;
import pic from "../img/book-store-logo.png";

function Header() {
  return (
    <div className='header container'>
        <div>
        <img src={pic} alt="" />
        </div>
        <div className='right-side'>Menu</div>
    </div>
  )
}

export default Header;