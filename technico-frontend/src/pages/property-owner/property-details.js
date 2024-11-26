import { useEffect, useState } from 'react';
import axios from 'axios';
 
export default function PropertyDetailsPage() {
    const [properties, setProperties] = useState([]);
 
    useEffect(() => {
        // Fetch properties for the current property owner
        axios.get('/api/propertyitems')
            .then(response => setProperties(response.data))
            .catch(error => console.error("Error fetching properties", error));
    }, []);
 
    return (
<div>
<h1>My Properties</h1>
<ul>
                {properties.map(property => (
<li key={property.id}>{property.address} - {property.yearOfConstruction}</li>
                ))}
</ul>
</div>
    );
}