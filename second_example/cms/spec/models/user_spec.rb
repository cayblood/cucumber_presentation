require 'spec_helper'

describe User do
  it "should enforce name uniqueness" do
    User.create!(:name => 'Bob')
    User.new(:name => 'Bob').should_not be_valid    
  end
end
