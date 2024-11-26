import { useEffect, useState } from 'react';
import axios from 'axios';
 
export default function RepairsPage() {
    const [repairs, setRepairs] = useState([]);
 
    useEffect(() => {
        // Fetch repairs for the current property owner
        axios.get('/api/propertyrepair')
            .then(response => setRepairs(response.data))
            .catch(error => console.error("Error fetching repairs", error));
    }, []);
 
    return (
<div>
<h1>My Repairs</h1>
<ul>
                {repairs.map(repair => (
<li key={repair.id}>{repair.description} - {repair.status}</li>
                ))}
</ul>
</div>
    );
}