import React from "react";
import "../CssFiles/Header.css"
import { useLanguage } from "../../contexts/LanguageContext";

const Header: React.FC = () => {
    const { language } = useLanguage();
    return (
        <section id="home">
            <header className="header">
                <div className="blue-gradient">
                    <div className="text-container">
                        <h1 className="header-title1">{language ==="en" ? "All In One Platform" : "Tek Bir Platformda"}</h1>
                        <h2 className="header-title2">{language === "en" ? "One-Step Solutions For Your Project" : "Projeniz İçin Tek Adımda Çözümler"}</h2>
                    </div>
                    <div className="header-image">
                        <img src="/images/22.png" alt="image"/>
                    </div>
                    <div className="header-image-2">
                        <img src="/images/siyesoBirds.png"/>
                    </div>
                </div>
            </header>
        </section>
    );
};

export default Header;