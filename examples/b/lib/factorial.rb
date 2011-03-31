class Factorial
  def self.calc(num)
    if num == 0 or num == 1
      1
    else
      num * self.calc(num - 1)
    end
  end
end