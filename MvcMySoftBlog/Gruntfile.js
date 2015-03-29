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
                files: ['**/*js','**/*aspx'],
                options: {
                    livereload: true
                }
            }
        }
    });
    // These plugins provide necessary tasks.
    grunt.loadNpmTasks('grunt-contrib-watch');
    //load auto test package
    grunt.loadNpmTasks('grunt-contrib-qunit');
    // By default, lint and run all tests.
    grunt.registerTask('default', ['watch']);

};