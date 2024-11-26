import { useState } from 'react';
import axios from 'axios';
import { useRouter } from 'next/router';

export default function LoginPage() {
   const [email, setEmail] = useState('');
   const [password, setPassword] = useState('');
   const router = useRouter();
   const handleLogin = async (e) => {
       e.preventDefault();
       try {
           // Implement login logic here and redirect based on role
           // e.g., router.push('/home');
       } catch (error) {
           console.error("Login failed", error);
       }
   };
   return (
       
<div>
              
   <h1>Login</h1>
              
   <form onSubmit={handleLogin}>
                     <input 
                         type="email" 
                         value={email} 
                         onChange={(e) => setEmail(e.target.value)} 
                         placeholder="Email" 
                         required 
                     />
                     <input 
                         type="password" 
                         value={password} 
                         onChange={(e) => setPassword(e.target.value)} 
                         placeholder="Password" 
                         required 
                     />
                     <button type="submit">Login</button>
                 
   </form>
          
</div>
   );
}