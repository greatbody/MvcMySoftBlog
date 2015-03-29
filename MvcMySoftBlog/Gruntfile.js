/*
* grunt-init
* https://gruntjs.com/
*
* Copyright (c) 2014 "Cowboy" Ben Alman, contributors
* Licensed under the MIT license.
*/

'use strict';

module.exports = function (grunt) {

    // Project configuration.
    grunt.initConfig({
        watch: {
            client: {
                files: ['Scripts/*/*.js', 'Views/**/*aspx'],
                options: {
                    livereload: true
                }
            }
        }
    });

    // These plugins provide necessary tasks.
    grunt.loadNpmTasks('grunt-contrib-watch');

    // By default, lint and run all tests.
    grunt.registerTask('default', ['watch']);

};