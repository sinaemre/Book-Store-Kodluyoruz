import React from 'react'

import Header from '../components/Header'
import { NavLink } from 'react-router-dom'

import Products from '../components/Products'


function Home() {
  return (
    <div>
    
    <Header/>
    

    
    <div className='container mt-5'>
      <div className='row'>

       <div >
         <Products />
       </div>
      </div>

    </div>

    </div>
  )
}

export default Home