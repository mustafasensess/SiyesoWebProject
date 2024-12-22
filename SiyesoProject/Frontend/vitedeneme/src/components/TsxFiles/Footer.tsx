import React from "react";
import "../CssFiles/Footer.css"
import {useLanguage} from "../../contexts/LanguageContext.tsx";

const Footer: React.FC = () => {

    const {language} = useLanguage();
    return (
        <section id="contact">
            <footer className="footer">
                <div className="footer-content">
                    <img src="siyeso_yazilim_logo.png" alt="Logo" className="footer-logo"/>
                    <div className="footer-info">
                        {language === "en" ? (
                            <h3>Our Information</h3>
                        ) : (
                            <h3>Bilgilerimiz</h3>
                        )}
                        {language === "en" ? (
                            <p>Address: Sanayi Mahallesi, Teknopark Bulvarı, No: 1 / 2C İç Kapı No: 2105 Pendik
                                İSTANBUL</p>
                        ) : (
                            <p>Adres: Sanayi Mahallesi, Teknopark Bulvarı, No: 1 / 2C İç Kapı No: 2105 Pendik
                                İSTANBUL</p>
                        )}
                        {language === "en" ? (
                            <p>Office: +90 532 595 97 09</p>
                        ) : (
                            <p>Ofis: +90 532 595 97 09</p>
                        )}
                        {language === "en" ? (
                            <p>Contact: <a href="mailto:info@siyeso.com">info@siyeso.com</a></p>
                        ) : (
                            <p>Destek: <a href="mailto:info@siyeso.com">info@siyeso.com</a></p>
                        )}

                    </div>
                </div>
                <div className="footer-bottom">
                    {language === "en" ? (
                        <p>&copy; 2024 All rights reserved.</p>
                    ) : (
                        <p>&copy; 2024 Tüm haklar saklıdır.</p>
                    )}
                </div>
            </footer>

        </section>
    );
}
export default Footer;
