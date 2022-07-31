import Button from 'react-bootstrap/Button';
import Card from 'react-bootstrap/Card';
import { useEffect, useState } from 'react';
import React from 'react';
import axios from 'axios';

function Cards() {
  const [data, setData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      const response = await axios.get("https://localhost:44349/api/Books/4");
      console.log(response.data.bookTitle);
      setData(response.data);
    }

    fetchData();
  }, []);
  return (
    <Card style={{ width: '18rem' }}>
      <Card.Img variant="top" src={data.imagePath} />
      <Card.Body>
            <Card.Title>{data.bookTitle}</Card.Title>
        <Card.Text>
          {data.description}
        </Card.Text>
        <Button variant="primary">Satın Al</Button>
      </Card.Body>
    </Card>
  );
}

export default Cards;
