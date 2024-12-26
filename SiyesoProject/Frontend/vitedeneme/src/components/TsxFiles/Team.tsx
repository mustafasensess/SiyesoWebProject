import React, {useState, useEffect} from "react";
import {Carousel} from "antd";
import axios from "axios";
import "../CssFiles/Team.css";
import {useLanguage} from "../../contexts/LanguageContext.tsx";
import {ArrowLeftOutlined, BackwardOutlined, CaretLeftOutlined, LeftOutlined, RightOutlined} from "@ant-design/icons";


interface TeamData {
    profileTitle: string;
    profileName: string;
    profileTitleEn: string;
    profilePicture: string;
}
const CustomPrevArrow = ({ className, style, onClick }) => (
    <div
        className={className}
        style={{ ...style, fontSize: '20px', color: 'black', zIndex: 1 }}
        onClick={onClick}
    >
        <LeftOutlined />
    </div>
);
const CustomNextArrow = ({ className, style, onClick }) => (
    <div
        className={className}
        style={{ ...style, fontSize: '20px', color: 'black', zIndex: 1 }}
        onClick={onClick}
    >
        <RightOutlined />
    </div>
);

const Team: React.FC = () => {
    const [teamData, setTeamData] = useState<TeamData[]>([]);
    const [error, setError] = useState(false);
    const {language} = useLanguage();

    useEffect(() => {
        const fetchTeamData = async () => {
            try {
                const response = await axios.get("http://localhost:5151/api/Team");
                console.log("API response:", response.data.data);
                if (Array.isArray(response.data.data)) {
                    setTeamData(response.data.data);
                } else {
                    console.error("API response is not an array:", response.data.data);
                    setError(true);
                }
            } catch (error) {
                console.error("Error fetching team data:", error);
                setError(true);
            }
        };

        fetchTeamData();
    }, []);

    if (error) {
        return <div>Error loading team data. Please try again later.</div>;
    }

    return (
        <section
            id="team"
            style={{
                padding: "50px",
                backgroundColor: "white",
                marginTop: "30px",
                marginBottom: "100px",
            }}
        >
            <div className="team sm:text-center">
                <h1 className="team-title">
                    {language === "en" ? "Our Team" : "Takım"}
                </h1>
                <h2 className="team-description">
                    {language === "en"
                        ? "With our continuously expanding and experienced team, we are able to keep delivering 'innovative solutions'."
                        : "Her geçen gün büyüyen, deneyimli kadromuz ile birlikte 'yenilikçi çözümler' sunmaya devam edebiliyoruz"}
                </h2>
                {teamData.length > 0 ? (
                    <div className="team-carousel">
                        <Carousel
                            dots={false}
                            autoplay
                            autoplaySpeed={1700}
                            slidesToShow={3}
                            arrows
                            responsive={[
                                {
                                    breakpoint: 900,
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
                            {teamData.map((user, index) => (
                                <div key={index} className="team-carousel-item">
                                    <img
                                        className="team-profile-pic"
                                        src={user.profilePicture}
                                        alt={user.profileName}
                                    />
                                    <div className="team-cont">
                                        <h3 className="font-bold text-lg">{user.profileName}</h3>
                                        <p className="text-base">
                                            {language === "en"
                                                ? user.profileTitleEn
                                                : user.profileTitle}
                                        </p>
                                    </div>
                                </div>
                            ))}
                        </Carousel>
                    </div>
                ) : (
                    <div>Loading team data...</div>
                )}
            </div>
        </section>
    );
};

export default Team;
