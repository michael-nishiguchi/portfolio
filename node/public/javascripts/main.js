//navigation
function openNav() {
	// document.getElementById('mySidenav').style.width = '350px';
	document.getElementById('mySidenav').classList.add('mobile-nav');
}
function closeNav() {
	document.getElementById('mySidenav').classList.remove('mobile-nav');
	// document.getElementById('mySidenav').style.width = '0';
	// document.getElementById('content').style.marginLeft = '0';
}

//toggle theme
window.onload = function() {
	var checkbox = document.querySelector('input[name=theme]');

	checkbox.addEventListener('change', function() {
		console.log('here');
		if (this.checked) {
			trans();
			document.documentElement.setAttribute('data-theme', 'dark');
		} else {
			trans();
			document.documentElement.setAttribute('data-theme', 'light');
		}
	});

	document.getElementById('close-modal').addEventListener('click', function() {
		document.getElementById('modal').style.display = 'none';
	});

	//display adobe projects
	// document.getElementById('adobe a').addEventListener('click', function() {
	document.querySelector('#adobe a').addEventListener('click', function() {
		console.log('here');
		document.getElementsByClassName('adobe-item').toggleClass('show');
		document.getElementById('contact').toggleClass('transition-contact');
	});
	// 	$('.adobe-item').toggleClass('show');
	// 	$('#contact').toggleClass('transition-contact');
	// });

	// $('#adobe a').click(function() {
	// 	$('.adobe-item').toggleClass('show');
	// 	$('#contact').toggleClass('transition-contact');
	// });

	//check if window @ width
	if (window.innerWidth > 1200 && document.getElementById('mySidenav').style.width == '350px') {
		document.getElementById('mySidenav').style.width = '100%';
	}
	// } else {
	// 	document.getElementById('mySidenav').style.width = 'auto';
	// }
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
