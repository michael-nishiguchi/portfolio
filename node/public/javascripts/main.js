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

	var light = true;

	checkbox.addEventListener('change', function() {
		console.log('here');
		if (this.checked) {
			trans();
			light = false;
			document.documentElement.setAttribute('data-theme', 'dark');
		} else {
			trans();
			light = true;
			document.documentElement.setAttribute('data-theme', 'light');
		}
	});

	if (document.getElementById('close-modal') != null) {
		document.getElementById('close-modal').addEventListener('click', function() {
			document.getElementById('modal').style.display = 'none';
		});
	}

	// document.querySelector('#adobe a').addEventListener('click', function() {
	// 	console.log('here');
	// 	document.getElementsByClassName('adobe-item').toggleClass('show');
	// 	document.getElementById('contact').toggleClass('transition-contact');
	// });

	//check if window @ width
	if (window.innerWidth > 1200 && document.getElementById('mySidenav').style.width == '350px') {
		document.getElementById('mySidenav').style.width = '100%';
	}

	//canvas animation
	var c = document.getElementById('canv');
	var $ = c.getContext('2d');
	var w = (c.width = 550);
	var h = (c.height = 550);
	var position = [w / 2, h / 2];
	var spacing = 30;
	var numw = w / spacing;
	var numh = h / spacing;

	var grayOpaque = 'rgba(67, 67, 67, .7)';
	var gray = 'rgba(67, 67, 67, 1)';
	var yellow = 'rgba(238, 155, 2, 1)';
	var blue = 'rgba(2, 86, 238, .7)';
	var lightBackground = 'rgba(226, 225, 224, 1)';
	var lightBackgroundOpaque = 'rgba(226, 225, 224, .7)';

	var background;
	var backgroundOpaque;
	var color;

	var draw = function(p) {
		if (light == true) {
			background = lightBackground;
			backgroundOpaque = lightBackgroundOpaque;
			color = yellow;
		} else {
			background = grayOpaque;
			backgroundOpaque = gray;
			color = blue;
		}

		$.fillStyle = backgroundOpaque;
		$.fillRect(0, 0, w, h);

		$.fillStyle = background;

		$.strokeStyle = color;
		for (var i = 0; i < numh; i++)
			for (var j = 0; j < numw; j++) {
				var diagnalW = j * spacing + (i % 2 ? 0 : spacing / 2);
				var diagnalH = i * spacing;
				var arr = [position[0] - diagnalW, position[1] - diagnalH],
					wave = Math.sqrt(arr[0] * arr[0] + arr[1] * arr[1]),
					arr = [arr[0] / wave, arr[1] / wave],
					angle = 50 * (Math.cos(p / 360 - wave / 105) - 1);
				$.beginPath();
				$.arc(diagnalW + arr[0] * angle, diagnalH + arr[1] * angle, 2.8, 0, 2 * Math.PI, false);
				$.closePath();
				$.fill();
				for (var n = 0; n < 5; n++) {
					var tail = 50 * (Math.cos((p - 50 * n) / 360 - wave / 105) - 1);
					$.beginPath();
					$.moveTo(diagnalW + arr[0] * angle, diagnalH + arr[1] * angle);
					$.lineWidth = 5 - n;
					$.lineTo(diagnalW + arr[0] * tail, diagnalH + arr[1] * tail);
					$.stroke();
				}
			}
	};
	var anim = function(p) {
		window.requestAnimationFrame(anim);
		draw(p);
	};
	anim();

	/****************47 Lines****
Above Canvas Text Lines (#42-52) are unncessary && therefore do not count as part of the 50 Lines -
Because I said so.
*******************/
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
