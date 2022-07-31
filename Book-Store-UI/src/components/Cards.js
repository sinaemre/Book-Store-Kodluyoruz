
import Button from 'react-bootstrap/Button';
import Card from 'react-bootstrap/Card';
import { Container } from 'react-bootstrap';

function Cards( { item } ) {


  return (
    <Container>
     
      
        <Card style={{ width: '18rem' }}   >
          <Card.Img variant="top" src={item.image} />
            <Card.Body>
            <Card.Title >{item.title}</Card.Title>
            <Card.Text>{item.description}</Card.Text>
          <Button variant="primary">Satın Al</Button>
        </Card.Body>
      </Card>
    
    
    
    </Container>
  
  );
}

export default Cards;
