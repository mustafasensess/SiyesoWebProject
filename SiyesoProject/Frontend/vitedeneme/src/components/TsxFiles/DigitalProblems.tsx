import React, { useEffect, useState } from "react";
import { Card, Space, Row, Col } from "antd";
import "../CssFiles/DigitalProblems.css";
import axios from "axios";
import { useLanguage } from "../../contexts/LanguageContext";

interface DigitalProblem {
    id: number;
    image: string;
    title: string;
    description: string;
    titleEn: string;
    descriptionEn: string;
}

const DigitalProblems: React.FC = () => {
    const [cards, setCards] = useState<DigitalProblem[]>([]);
    const { language } = useLanguage();

    useEffect(() => {
        const fetchDigitalProblems = async () => {
            try {
                const response = await axios.get("http://localhost:5151/api/DigitalProblems");
                if (Array.isArray(response.data.data)) {
                    setCards(response.data.data);
                } else {
                    console.error("API response is not an array:", response.data.data);
                }
            } catch (error) {
                console.error("Error fetching digital problems:", error);
            }
        };

        fetchDigitalProblems();
    }, []);

    return (
        <section id="digitalProblems">
            <div className="digitalProblems">
                <h1>{language==="en" ? "Common Problems About Digitalization" : "Dijitalleşmedeki Ortak Problemler"}</h1>
                <h2>{language==="en" ? "The more companies grow, the better projects emerge. But there are common problems that need to be solved" : "Şirketler büyüdükçe daha iyi projeler ortaya çıkabiliyor. Ancak çözülmesi gereken ortak problemler var."}</h2>
                <Space
                    direction="vertical"
                    size={16}
                    style={{
                        width: "100%",
                        maxWidth: "1200px",
                        margin: "0 auto",
                        justifyContent: "center",
                        alignItems: "center",
                        display: "flex",
                    }}
                >
                    <Row justify="center" gutter={[16, 16]}>
                        {cards.map((card) => (
                            <Col key={card.id}>
                                <Card
                                    hoverable
                                    className="custom-card"
                                    cover={<img alt={card.title} src={card.image} />}
                                >
                                    <Card.Meta
                                        title={language === "en" ? card.titleEn :card.title}
                                        description={language === "en" ? card.descriptionEn :card.description}
                                    />
                                </Card>
                            </Col>
                        ))}
                    </Row>
                </Space>
            </div>
        </section>
    );
};

export default DigitalProblems;
