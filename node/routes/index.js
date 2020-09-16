var express = require('express');
const https = require('https');
const http = require('http');
const { Http2ServerRequest } = require('http2');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
	res.render('index', { title: 'Express' });
});

/*
router.get('/league', function(req, res, next) {
	//https://api.nytimes.com/svc/mostpopular/v2/emailed/7.json?api-key=p7qxACKrkRzaWoswy2mvAGBGQ0faP7oW
	http.get('http://ddragon.leagueoflegends.com/cdn/10.16.1/data/en_US/champion.json', (res) => {
		console.log('status code: ', res.statusCode);
		//console.log('headers: ', res.headers);
	});
	if (res.statusCode == 200) {
	}
	res
		.on('data', (d) => {
			process.stdout.write(d);
			console.log(d);
		})
		.on('end', ()
		.on('error', (e) => {
			console.error(e);
		});
		request(
		'http://ddragon.leagueoflegends.com/cdn/10.16.1/data/en_US/champion.json',
												{ json: true },
												(err, res, body) => {
													if (err) {
														return console.log(err);
													}
													console.log(body.url);
													console.log(body.explanation);
												}
											);
	
	res.render('league', {
		title: 'Express'
	});
});
*/

router.get('');

router.post('/sendEmail', function(req, res) {
	var nodemailer = require('nodemailer');
	var subject = req.body.subject;
	var text = req.body.message;
	if (typeof subject == 'undefined' || typeof text == 'undefined') {
		console.log('No subject/text for email. Not sent');
		res.render('index', {
			title: 'Express',
			email: false
		});
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
	var conditional = true;

	res.render('index', {
		title: 'Express',
		email: true
	});
});

module.exports = router;
