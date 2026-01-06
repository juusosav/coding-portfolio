// Fade in scroll
window.initScrollAnimations = () => {
    const elements = document.querySelectorAll('.fade-in');

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('visible');
            }
        });
    }, { threshold: 0.2 });

    elements.forEach(el => observer.observe(el));
};

// 'Back to top' fadeout
window.addEventListener("scroll", function () {
    const brand = document.querySelector(".navbar-brand");
    if (!brand) return;

    if (window.scrollY > 10) {
        brand.classList.add("visible");
    } else {
        brand.classList.remove("visible");
    }
});


// EmailJS form sending logic
window.sendEmail = async (form) => {
    try {
        await emailjs.sendForm(
            "service_jv5bf89",
            "template_contact",
            form
        );
        return true;
    } catch (e) {
        console.error("EmailJS error:", e);
        return false;
    }
};