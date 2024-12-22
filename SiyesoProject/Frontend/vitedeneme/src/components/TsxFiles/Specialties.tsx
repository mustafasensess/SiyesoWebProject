import React, { useEffect, useState } from "react";
import "../CssFiles/Specialties.css";
import axios from "axios";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {faBusinessTime, faChartLine, faLightbulb, faCoins} from "@fortawesome/free-solid-svg-icons";
import {useLanguage} from "../../contexts/LanguageContext.tsx";

const iconMapping = {
    "fa-business-time": faBusinessTime,
    "fa-chart-line": faChartLine,
    "fa-lightbulb": faLightbulb,
    "fa-coins": faCoins
};

const Specialties: React.FC = () => {
    const [specialtiesList, setSpecialtiesList] = useState([]);
    const { language } = useLanguage();

    useEffect(() => {
        const fetchSpecialties = async () => {
            try {
                const response = await axios.get("http://localhost:5151/api/Specialties");
                if (Array.isArray(response.data.data)) {
                    setSpecialtiesList(response.data.data);
                } else {
                    console.error("API response is not an array:", response.data.data);
                }
            } catch (error) {
                console.error("Error fetching specialties:", error);
            }
        };
        fetchSpecialties();
    }, []);

    useEffect(() => {
        console.log(specialtiesList);
    }, [specialtiesList]);

    return (
        <section id="specialties">
            <div className="specialties-container">
                <h1 className="specialties-h1">{language === "en" ? "Our Expertise" : "Uzmanlık Alanlarımız"}</h1>
                <div className="specialties-grid">
                    {specialtiesList.map((item) => (
                        <div
                            key={item.id}
                            className="specialty-card"
                            style={{ borderTop: `5px solid ${item.borderColor}` }}
                        >
                            <div className="icon-box">
                                <FontAwesomeIcon icon={iconMapping[item.image]} className="icon" />
                            </div>
                            <h2>{language === "en" ? item.titleEn :item.title}</h2>
                            <p>{language === "en" ? item.descriptionEn :item.description}</p>
                        </div>
                    ))}
                </div>
            </div>
        </section>
    );
};

export default Specialties;
