import '../styles/globals.css';
import Link from 'next/link';
 
function MyApp({ Component, pageProps }) {
    return (
<>
<nav>
<ul>
<li><Link href="/login">Login</Link></li>
<li><Link href="/property-owner/home">Home</Link></li>
<li><Link href="/property-owner/property-details">Property Details</Link></li>
<li><Link href="/property-owner/repairs">Repairs</Link></li>
</ul>
</nav>
<Component {...pageProps} />
</>
    );
}
 
export default MyApp;