//navigation
function openNav() {
	document.getElementById('mySidenav').style.width = '350px';
}
function closeNav() {
	document.getElementById('mySidenav').style.width = '0';
	document.getElementById('content').style.marginLeft = '0';
}

//toggle theme
window.onload = function() {
	var checkbox = document.querySelector('input[name=theme]');

	checkbox.addEventListener('change', function() {
		console.log('here');
		if (this.checked) {
			trans();
			document.documentElement.setAttribute('data-theme', 'dark');
		}
		else {
			trans();
			document.documentElement.setAttribute('data-theme', 'light');
		}
	});
};

let trans = () => {
	document.documentElement.classList.add('transition');
	window.setTimeout(() => {
		document.documentElement.classList.remove('transition');
	}, 200);
};

function toggleTheme() {
	console.log('toggle');
	const htmlTag = document.getElementsByTagName('html')[0];
	console.log(htmlTag);
	if (htmlTag.hasAttribute('data-theme')) {
		htmlTag.removeAttribute('data-theme');
		return window.localStorage.removeItem('site-theme');
	}

	htmlTag.setAttribute('data-theme', 'dark');
	window.localStorage.setItem('site-theme', 'dark');
}

function applyInitialTheme() {
	const theme = window.localStorage.getItem('site-theme');
	if (theme !== null) {
		const htmlTag = document.getElementsByTagName('html')[0];
		htmlTag.setAttribute('data-theme', theme);
	}
}
