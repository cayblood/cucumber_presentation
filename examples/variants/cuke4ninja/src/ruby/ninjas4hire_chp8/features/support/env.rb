# Generated by cucumber-sinatra. (Tue Nov 23 21:41:31 +0000 2010)

ENV['RACK_ENV'] = 'test'

require File.join(File.dirname(__FILE__), '..', '..', 'src/ninjas4hire_app.rb')

require 'capybara'
require 'capybara/cucumber'
require 'rspec'

Capybara.app = Ninjas4HireApp

class Ninjas4HireAppWorld
  include Capybara
  include RSpec::Expectations
  include RSpec::Matchers
end

World do
  Ninjas4HireAppWorld.new
end
