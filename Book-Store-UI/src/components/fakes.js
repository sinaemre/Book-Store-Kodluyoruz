
import axios from 'axios'

import React from 'react'

const fakes = async (id) => {
    const { veri } = await axios.get(`https://fakestoreapi.com/products/${id}`)
  return veri;
}

export default fakes
