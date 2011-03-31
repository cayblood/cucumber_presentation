Given /^I have the number (\d+)$/ do |num|
  @operand = Integer(num)
end

When /^I compute its factorial$/ do
  @result = Factorial.calc(@operand)
end

Then /^I see the number (\d+)$/ do |result|
  @result.should == Integer(result)
end
