var createError = require('http-errors');
var express = require('express');
var path = require('path');

var app = express();
//set port
app.set('port', process.env.PORT || 3000);
app.listen(app.get('port'), function() {
	console.log('Node server is running on port ' + app.get('port'));
});

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'pug');

//app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(express.static(path.join(__dirname, 'public')));

//routing

/* GET home page. */
app.get('/', function(req, res, next) {
	res.render('index', { title: 'Express' });
});

app.post('/sendEmail', function(req, res) {
	var nodemailer = require('nodemailer');
	var subject = req.body.subject;
	var text = req.body.message;
	if (typeof subject == 'undefined' || typeof text == 'undefined') {
		console.log('No subject/text for email. Not sent');
		res.render('index', { title: 'Express' });
	}

	var transporter = nodemailer.createTransport({
		service: 'Gmail',
		auth: {
			user: 'guchijunk@gmail.com',
			pass: '8%f}V5[~WSug'
		}
	});

	var mailOptions = {
		from: 'Portfolio Contact <guchijunk@gmail.com>',
		to: 'mikenishiguchi@gmail.com',
		subject: subject,
		text: text
	};

	transporter.sendMail(mailOptions, function(error, info) {
		if (error) {
			console.log(error);
		}
		else {
			console.log('Email sent: ' + info.response);
		}
	});

	res.render('index', { title: 'Express' });
});

// catch 404 and forward to error handler

app.use(function(req, res, next) {
	next(createError(404));
});

// error handler
app.use(function(err, req, res, next) {
	// set locals, only providing error in development
	res.locals.message = err.message;
	res.locals.error = req.app.get('env') === 'development' ? err : {};

	// render the error page
	res.status(err.status || 500);
	res.render('error');
});

module.exports = app;
