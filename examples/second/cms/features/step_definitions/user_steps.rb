Given /^I have users named (.*)$/ do |user_names|
  names = user_names.split
  names.each do |name|
    User.create!(:name => name)
  end
end