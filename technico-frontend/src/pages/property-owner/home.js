import { useEffect, useState } from 'react';
import axios from 'axios';
 
export default function PropertyOwnerHomePage() {
    const [repairs, setRepairs] = useState([]);
 
    useEffect(() => {
        axios.get('/api/repairs')
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