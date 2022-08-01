import React from 'react'

import Header from '../components/Header'
import { NavLink } from 'react-router-dom'

import Products from '../components/Products'
import SearchInput from '../components/SearchInput'


function Home() {
  return (
    <div>
    
    <Header/>
    

    
    <div className='container mt-5'>
      <div className='row'>

      <SearchInput/>
       <div >
         <Products />
       </div>
      </div>

    </div>

    </div>
  )
}

export default Home