import React, { useEffect, useState } from "react";
import axios from "axios";
import { Carousel } from "antd";
import { useLanguage } from "../../contexts/LanguageContext";
import "../CssFiles/Reference.css";

const imgStyle: React.CSSProperties = {
    maxWidth: "200px",
    maxHeight: "80px",
    objectFit: "contain",
    margin: "0 auto",
    marginBottom: "40px",
};

const Reference: React.FC = () => {
    const [data, setData] = useState<{ logos: string[]; title: string; description: string, titleEn: string, descriptionEn: string } | null>(null);
    const [error, setError] = useState(false);
    const { language } = useLanguage();

    useEffect(() => {
        axios
            .get("http://localhost:5151/api/Reference")
            .then((response) => {
                console.log("API response:", response.data.data);
                if (response.data.data && response.data.data.length > 0) {
                    setData(response.data.data[0]);
                } else {
                    setError(true);
                }
            })
            .catch((error) => {
                console.error("Error fetching data:", error.response || error.message);
                setError(true);
            });
    }, []);


    if (error || !data) {
        return <div>Error loading data. Please try again later.</div>;
    }

    return (
        <section  className="references" style={{ padding: "50px", backgroundColor: "white", marginTop: "30px", marginBottom: "100px" }}>
            <div className="ref-content sm:text-center">
                <h1 className="ref-content-h1">
                    {language === "en" ? data.titleEn : data.title}
                </h1>
                <h2 className="ref-content-h2">
                    {language === "en" ? data.descriptionEn : data.description}
                </h2>
                <Carousel
                    autoplay
                    autoplaySpeed={2000}
                    slidesToShow={4}
                    dots
                    responsive={[
                        {
                            breakpoint: 1200,
                            settings: {
                                slidesToShow: 3,
                            },
                        },
                        {
                            breakpoint: 768,
                            settings: {
                                slidesToShow: 2,
                            },
                        },
                        {
                            breakpoint: 480,
                            settings: {
                                slidesToShow: 1,
                            },
                        },
                    ]}
                >
                    {Array.isArray(data.logos) && data.logos.map((logo, index) => (
                        <div key={index} className={`carousel-item ${index === 2 ? "adjust-position" : ""}`}>
                            <img src={logo} alt={`Logo ${index}`} style={imgStyle} className="itc" />
                        </div>
                    ))}
                </Carousel>
            </div>
        </section>
    );
};

export default Reference;
