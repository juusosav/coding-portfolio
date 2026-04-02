window.navHelper = {
    closeMenu: function () {
        const toggler = document.getElementById('navbarNav');
        if (toggler) {
            toggler.checked = false;
        }

        const navCollapse = document.getElementById('navbarNav');
        if (navCollapse && window.bootstrap) {
            const collapse = bootstrap.Collapse.getInstance(navCollapse);
            if (collapse) collapse.hide();
        }
    }
}