import React from 'react'
import Cards from '../components/Cards'
import Header from '../components/Header'

import Login from '../components/Login'
import Slider from '../components/Slider'

function Home() {
  return (
    <div>
    
    <Header/>
    
    <div className='container mt-5'>
        <div className='row'>
          
          <div className='sliderPart col-md-9'>
            <Slider/>
          </div>
          <div className='col-md-3'>
            <Login />
        </div>
        <div className='cards'>
        <Cards />
        <Cards/>
        <Cards/>
        
        </div>


        </div>

    </div>

    </div>
  )
}

export default Home