
import React, {useEffect, useState} from "react";
import "../CssFiles/AboutUs.css"
import axios from "axios";
import {useLanguage} from "../../contexts/LanguageContext.tsx";


interface AboutData {
    id: number;
    title: string;
    description: string;
    picture: string;
    titleEn: string;
    descriptionEn: string;
}

const AboutUs: React.FC = () => {
    const [aboutData, setAboutData] = useState<AboutData | null>(null);
    const { language } = useLanguage();

    useEffect(() => {
        const fetchAboutUs = async () => {
            try {
                const response = await axios.get('http://localhost:5151/api/AboutUs');
                if (response.data.data && response.data.data.length > 0) {
                    setAboutData(response.data.data[0]);
                } else {
                    console.error('API response is empty or invalid:', response.data.data);
                }
            } catch (error) {
                console.error('Error fetching about us data:', error);
            }
        };
        fetchAboutUs();
    }, []);

    return (
        <section id="about">
            {aboutData && (
                <div className="AboutUs">
                    <h1 className="about-h1">{language === "en" ? aboutData.titleEn :aboutData.title}</h1>
                    <div className="content">
                        <p className="paragraph">{language === "en" ? aboutData.descriptionEn :aboutData.description}</p>
                        <div className="img">
                            <img src={aboutData.picture} alt="About Us" className="about"/>
                        </div>
                    </div>
                </div>
            )}
        </section>
    );
};
export default AboutUs;



