import React from 'react'
import Cards from '../components/Cards'
import Header from '../components/Header'

import Login from '../components/Login'
import Products from '../components/Products'
import SearchInput from '../components/SearchInput'
import Slider from '../components/Slider'

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