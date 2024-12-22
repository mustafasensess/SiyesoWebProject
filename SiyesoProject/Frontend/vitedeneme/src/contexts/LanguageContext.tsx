import React, { createContext, useState, useContext, ReactNode } from "react";

// Dil türlerini tanımla
type Language = "tr" | "en";

// Dil context'i için arayüz
interface LanguageContextType {
    language: Language;
    setLanguage: (language: Language) => void;
}

// Context oluştur
const LanguageContext = createContext<LanguageContextType | undefined>(undefined);

// Provider bileşeni
export const LanguageProvider = ({ children }: { children: ReactNode }) => {
    const [language, setLanguage] = useState<Language>("tr");

    return (
        <LanguageContext.Provider value={{ language, setLanguage }}>
            {children}
        </LanguageContext.Provider>
    );
};

// Hook ile kolay erişim
export const useLanguage = () => {
    const context = useContext(LanguageContext);
    if (!context) {
        throw new Error("useLanguage must be used within a LanguageProvider");
    }
    return context;
};
