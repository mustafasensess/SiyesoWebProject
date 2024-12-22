import React, { useEffect, useState } from "react";
import { Layout, Menu, Dropdown, Button, Drawer } from "antd";
import { Link } from "react-scroll";
import { GlobalOutlined, MenuOutlined } from "@ant-design/icons";
import { useMediaQuery } from "react-responsive";
import {useLanguage} from "../../contexts/LanguageContext.tsx";


const { Header } = Layout;

const Nav: React.FC = () => {

    const [isScrolled, setIsScrolled] = useState(false);
    const [drawerVisible, setDrawerVisible] = useState(false);
    const { setLanguage } = useLanguage();
    const {language} = useLanguage();


    const isMobileOrTablet = useMediaQuery({ maxWidth: 1024 });

    useEffect(() => {
        const handleScroll = () => {
            setIsScrolled(window.scrollY > 50);
        };
        window.addEventListener("scroll", handleScroll);
        return () => window.removeEventListener("scroll", handleScroll);
    }, []);

    const languageMenu = (
        <Menu>
            <Menu.Item key="en" onClick={() => setLanguage("en")}>
                English
            </Menu.Item>
            <Menu.Item key="tr" onClick={() => setLanguage("tr")}>
                Türkçe
            </Menu.Item>
        </Menu>
    );

    const showDrawer = () => setDrawerVisible(true);
    const closeDrawer = () => setDrawerVisible(false);

    return (
        <Layout>
            <Header
                style={{
                    position: "fixed",
                    top: 0,
                    zIndex: 1000,
                    width: "100%",
                    display: "flex",
                    alignItems: "center",
                    justifyContent: "space-between",
                    padding: "0 20px",
                    transition: "background-color 0.3s ease",
                    backgroundColor:isScrolled ? "rgba(0, 21, 41, 0.9)" : "black" ,
                    boxShadow: isScrolled ? "0 2px 8px rgba(0, 0, 0, 0.2)" : "none",
                }}
            >
                <div style={{ color: "white", fontSize: 20, fontWeight: "bold" }}>
                    <img src="/siyeso_yazilim_logo.png" alt="Logo" style={{ height: "52px" }} />
                </div>


                {!isMobileOrTablet && (
                    <Menu
                        theme="dark"
                        mode="horizontal"
                        defaultSelectedKeys={["0"]}
                        style={{
                            backgroundColor: "transparent",
                            borderBottom: "none",
                            display: "flex",
                            gap: "15px",
                        }}
                    >
                        <Menu.Item key="1">
                            <Link to="home" smooth={true} duration={500}>
                                {language === "tr" ? "Ana Sayfa" : "Home"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="2">
                            <Link to="about" smooth={true} duration={500}>
                                {language === "tr" ? "Hakkımızda" : "About"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="3">
                            <Link to="specialties" smooth={true} duration={500}>
                                {language === "tr" ? "Uzmanlık Alanlarımız" : "Our Expertise"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="4">
                            <Link to="references" smooth={true} duration={500}>
                                {language === "tr" ? "Referanslar" : "Reference"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="5">
                            <Link to="team" smooth={true} duration={500}>
                                {language === "tr" ? "Takım" : "Team"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="6">
                            <Link to="contact" smooth={true} duration={500}>
                                {language === "tr" ? "İletişim" : "Contact"}
                            </Link>
                        </Menu.Item>
                    </Menu>
                )}


                <div style={{display: "flex", alignItems: "center"}}>
                    <Dropdown overlay={languageMenu} trigger={["click"]}>
                        <GlobalOutlined
                            style={{
                                marginRight: "20px",
                                fontSize: "24px",
                                color: "darkgrey",
                                cursor: "pointer",
                            }}
                        />
                    </Dropdown>
                    {isMobileOrTablet && (
                        <Button
                            type="text"
                            icon={<MenuOutlined style={{fontSize: "24px", color: "darkgrey"}}/>}
                            onClick={showDrawer}
                        />
                    )}
                </div>


                <Drawer
                    title={language === "tr" ? "Menü" : "Menu"}
                    placement="right"
                    closable={true}
                    onClose={closeDrawer}
                    visible={drawerVisible}
                >
                    <Menu mode="vertical" onClick={closeDrawer}>
                        <Menu.Item key="1">
                            <Link to="home" smooth={true} duration={500}>
                                {language === "tr" ? "Ana Sayfa" : "Home"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="2">
                            <Link to="about" smooth={true} duration={500}>
                                {language === "tr" ? "Hakkımızda" : "About"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="3">
                            <Link to="specialties" smooth={true} duration={500}>
                                {language === "tr" ? "Uzmanlık Alanlarımız" : "Our Expertise"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="4">
                            <Link to="references" smooth={true} duration={500}>
                                {language === "tr" ? "Referanslar" : "Reference"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="5">
                            <Link to="team" smooth={true} duration={500}>
                                {language === "tr" ? "Takım" : "Team"}
                            </Link>
                        </Menu.Item>
                        <Menu.Item key="6">
                            <Link to="contact" smooth={true} duration={500}>
                                {language === "tr" ? "İletişim" : "Contact"}
                            </Link>
                        </Menu.Item>
                    </Menu>
                </Drawer>
            </Header>
        </Layout>
    );
};

export default Nav;
