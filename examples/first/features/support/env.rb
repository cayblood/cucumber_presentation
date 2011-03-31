require 'rubygems'
require 'bundler/setup'

require 'awesome_print'

require 'capybara'
require 'capybara/cucumber'

Capybara.run_server = false
Capybara.default_driver = :selenium