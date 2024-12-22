import React from "react";
import ReCAPTCHA from "react-google-recaptcha";

const ReCAPTCHAComponent: React.FC = () => {
    const siteKey = "6LenfpAqAAAAAFLcOdRz_dlgEuRb6P9RCq24W_-t"; // Google reCAPTCHA site key

    const onChange = (token: string | null) => {
        console.log("Token received:", token); // Backend'e doğrulama için gönderilecek token
    };

    return (
        <div>
            <ReCAPTCHA
                sitekey={siteKey}
                onChange={onChange}
            />
        </div>
    );
};

export default ReCAPTCHAComponent;
