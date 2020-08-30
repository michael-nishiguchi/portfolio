function openNav() {
	document.getElementById('mySidenav').style.width = '100%';
	//document.getElementById('main').style.marginLeft = '250px';
}

function closeNav() {
	document.getElementById('mySidenav').style.width = '0';
	document.getElementById('main').style.marginLeft = '0';
}

function toggleDark() {
	console.log('here');
	document.body.classList.toggle('darkMode');
}

const toggleSwitch = document.querySelector('.theme-switch input[type="checkbox"]');
const currentTheme = localStorage.getItem('theme');

if (currentTheme) {
	document.documentElement.setAttribute('data-theme', currentTheme);

	if (currentTheme === 'dark') {
		toggleSwitch.checked = true;
	}
}

function switchTheme(e) {
	if (e.target.checked) {
		document.documentElement.setAttribute('data-theme', 'dark');
		localStorage.setItem('theme', 'dark');
	}
	else {
		document.documentElement.setAttribute('data-theme', 'light');
		localStorage.setItem('theme', 'light');
	}
}

toggleSwitch.addEventListener('change', switchTheme, false);
