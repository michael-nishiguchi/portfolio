var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
	res.render('index', { title: 'Express' });
});

router.post('/sendEmail', function(req, res) {
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

module.exports = router;
