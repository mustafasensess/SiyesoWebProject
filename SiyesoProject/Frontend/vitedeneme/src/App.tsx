import './App.css'
import Header from "./components/TsxFiles/Header.tsx"
import Nav from "./components/TsxFiles/Nav.tsx";
import Footer from "./components/TsxFiles/Footer.tsx";
import Reference from "./components/TsxFiles/Reference.tsx";
import AboutUs from "./components/TsxFiles/AboutUs.tsx";
import Team from "./components/TsxFiles/Team.tsx";
import Specialties from "./components/TsxFiles/Specialties.tsx";
import DigitalProblems from "./components/TsxFiles/DigitalProblems.tsx";
import {LanguageProvider} from "./contexts/LanguageContext";


function App() {

    return (
        <div className="app">
            <LanguageProvider>
                <Nav/>
                <Header/>
                <DigitalProblems/>
                <AboutUs/>
                <Specialties/>
                <Reference/>
                <Team/>
                <Footer/>
            </LanguageProvider>
        </div>
    )
}

export default App
